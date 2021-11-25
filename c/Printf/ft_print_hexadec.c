/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_print_hexadec.c                                 :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/04/05 18:59:07 by lcasabel          #+#    #+#             */
/*   Updated: 2021/04/09 16:19:41 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"
#include "libft/libft.h"

void	ft_print_pointer(long int n, t_flags *flags)
{
	char	*num;
	char	*aux;

	num = ft_itoa_base(n, HEXA);
	if (!num)
		return ;
	aux = num;
	num = ft_strjoin("0x", num);
	free (aux);
	if (!ft_strncmp(num, "0x", 2) && flags->precission > 1)
		num = fill_zeros(num, flags->precission - 1);
	else if (!ft_strncmp(num, "0x0", 3) && flags->dot == 1)
	{
		if (flags->precission == 0)
		{
			aux = num;
			num = ft_strdup("0x\0");
			free(aux);
		}
	}
	ft_print_number(num, flags);
	free(num);
}

void	ft_print_hexa_lower(unsigned int n, t_flags *flags)
{
	char	*num;
	char	*aux;
	int		len;

	num = ft_itoa_base(n, HEXA);
	if (!num)
		return ;
	aux = num;
	len = ft_strlen(num);
	if (!ft_strncmp(num, "0", 1) && flags->dot == 1 && flags->precission == 0)
	{
		num = ft_strdup("\0");
		free(aux);
	}
	else if (flags->precission > len)
		num = fill_zeros(num, flags->precission - len);
	ft_print_number(num, flags);
	free(num);
}

void	ft_print_hexa_upper(unsigned int n, t_flags *flags)
{
	char	*num;
	char	*aux;
	int		len;

	num = ft_itoa_base(n, HEXA_UPPER);
	if (!num)
		return ;
	aux = num;
	len = ft_strlen(num);
	if (!ft_strncmp(num, "0", 1) && flags->dot == 1 && flags->precission == 0)
	{
		num = ft_strdup("\0");
		free(aux);
	}
	else if (flags->precission > len)
		num = fill_zeros(num, flags->precission - len);
	ft_print_number(num, flags);
	free(num);
}
