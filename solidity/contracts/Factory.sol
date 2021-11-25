//SPDX-License-Identifier: MIT
pragma solidity ^0.8.0;
pragma experimental ABIEncoderV2;

import '@openzeppelin/contracts-upgradeable/token/ERC1155/ERC1155Upgradeable.sol';
import './interfaces/IERC2981.sol';
import './FactoryStorage.sol';



contract Factory is ERC1155Upgradeable, IERC2981 {
    
    event NewMint(address artist, uint256 tokenId, uint256 amount, string name, uint24 fee);
    
    FactoryStorage factory_storage;

    address public factory_admin;

    string public  owners_uri;

    /**
     * @dev This is the constructor of the Factory contract.
    */
    function initialize(string memory _metadata, string memory _owners_uri, address _factoryStorage) virtual public initializer {
        __ERC1155_init(_metadata);
        factory_admin = _msgSender();
        owners_uri = _owners_uri;
        factory_storage = FactoryStorage(_factoryStorage);
    }

    function supportsInterface(bytes4 interfaceId) public view virtual override (ERC1155Upgradeable, IERC2981) returns (bool) {
        return (
        ERC1155Upgradeable.supportsInterface(interfaceId) 
        || interfaceId == type(IERC2981).interfaceId);
    }
    /**
    * @dev Mint a new asset
    */
    function createNFT (string memory _name, uint256 _amount, uint24 _fee) virtual public onlyAdmin {
        uint256 id = factory_storage.addNFT(_name, _amount, _fee);
        _mint(factory_storage.getArtist(), id, _amount, "");
        emit NewMint(factory_storage.getArtist(), id, _amount, _name, _fee);
    }
    /**
    * @dev EIP-2981 Royalties
    */
    function royaltyInfo(uint256 tokenId, uint256 _salePrice) virtual override external view returns (address _receiver, uint256 _royaltyAmount) {
        require(factory_storage._exists(tokenId), "invalid token");
        return (factory_storage.getRoyaltyRecipient(), uint256(factory_storage.getNFTModel(tokenId).fee) * _salePrice / 10000);
    }
    /**
    * @dev owner's benefits uri setter 
    */
    function setOwnersURI(string memory _owners_uri) public onlyAdmin {
        require(keccak256(abi.encodePacked((owners_uri))) != keccak256(abi.encodePacked((_owners_uri))), "this uri is already setted");
        owners_uri = _owners_uri;
    }
    /**
    * @dev Uri setter 
    */
    function setUrl(string memory _url) virtual public onlyAdmin {
        _setURI(_url);
        emit URI(_url, 0);
    }
    /**
     * @dev "factory_admin" setter
    */
    function setNewAdmin(address _newAdmin) public onlyAdmin {
        require(factory_admin != _newAdmin, "this address is already the admin");
        factory_admin = _newAdmin;
    }
    /**
     * @dev Burn token function  
    */
    function burn(address _account,uint256 _id,uint256 _amount) virtual  external  onlyOwner( _id) {
        _burn(_account, _id, _amount);
    }
    /**
     * @dev Getter for the storage NFT_ID varialbe
    */
    function getNFT_ID() public view returns (uint256) {
        return factory_storage.getNFT_ID();
    }
    /**
     * @dev Getter for the tokenAmount of the token Id
    */
    function getTokenAmount(uint256 _tokenId) public view returns (uint256) {
        return factory_storage.getTokenAmount(_tokenId);
    }
    /**
    * @dev function to be able to set things on Opensea 
    */
    function owner() public view returns (address) {
        return factory_admin;
    }
    /**
     * @dev This is the current recommended method for sending and receiving ETH
    */
    receive() external payable {}

    function sendValueCall(address payable recipient, uint256 amount) public onlyAdmin {
        require(address(this).balance >= amount, "Address: insufficient balance");

        (bool success, ) = recipient.call{value: amount}("");
        require(success, "Address: unable to send value, recipient may have reverted");
    }
    /**
    * @dev Function Modifiers
    */
    modifier onlyAdmin() {
        require(_msgSender() == factory_admin, "Only factory admin can do this");
        _;
    }

    modifier onlyOwner(uint256 _tokenId) {
        require(balanceOf(_msgSender(), _tokenId) > 0);
        _;
    }
}