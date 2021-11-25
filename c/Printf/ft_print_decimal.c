/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_print_decimal.c                                 :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/04/05 19:00:28 by lcasabel          #+#    #+#             */
/*   Updated: 2021/04/09 16:19:16 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"
#include "libft/libft.h"

void	ft_print_decimal(int n, t_flags *flags)
{
	char	*num;
	char	*aux;
	int		len;

	num = ft_itoa_base(n, NUMBER);
	aux = num;
	if (!num)
		return ;
	if (!ft_strncmp(num, "-", 1))
		len = ft_strlen(num) - 1;
	else
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

void	ft_print_uns_decimal(unsigned int n, t_flags *flags)
{
	char	*num;
	char	*aux;
	int		len;

	num = ft_itoa_base(n, NUMBER);
	aux = num;
	if (!num)
		return ;
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
