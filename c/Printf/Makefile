SRCS = ft_printf.c ft_print_functions.c aux_functions.c ft_flags.c ft_print_hexadec.c ft_print_decimal.c ft_print_letters.c 

LIB_PATH = ./libft
OBJS = ${SRCS:.c=.o}

BON = ${BONUS:.c=.o}

CC = gcc

CFLAGS = -Wall -Wextra -Werror

NAME = libftprintf.a

$(NAME):	$(OBJS)
			make -C $(LIB_PATH)
			cp $(LIB_PATH)/libft.a $(NAME)
			ar rc $(NAME) $(OBJS)		   		

all:		$(NAME)

clean:		
			make clean -C $(LIB_PATH)
			rm -f *.o

fclean:		clean
			make fclean -C $(LIB_PATH)
			rm -f $(NAME) 

re:			fclean all

.PHONY:		all clean fclean re
