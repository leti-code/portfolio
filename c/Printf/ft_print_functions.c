/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_print_functions.c                               :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/26 15:57:30 by lcasabel          #+#    #+#             */
/*   Updated: 2021/04/09 13:41:49 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"
#include "libft/libft.h"
#include <stdio.h>

void	common_pad(int width, char pad, t_flags *flags)
{
	int	i;

	i = 0;
	while (i < width)
	{
		flags->c_count += print_char(pad);
		i++;
	}
}

void	ft_check_flags(char *num, t_flags *flags, int width)
{
	if (flags->zero == 1 && (flags->dot == 0 || flags->precission < 0))
	{
		if (*num == '-')
		{
			flags->c_count += print_char('-');
			common_pad(width, '0', flags);
			flags->c_count += print_str(num + 1);
		}
		else if (*num == '0' && *(num + 1) == 'x')
		{
			flags->c_count += print_str("0x");
			common_pad(width, '0', flags);
			flags->c_count += print_str(num + 2);
		}
		else
		{
			common_pad(width, '0', flags);
			flags->c_count += print_str(num);
		}
	}
	else
	{
		common_pad(width, ' ', flags);
		flags->c_count += print_str(num);
	}
}

void	ft_print_number(char *num, t_flags *flags)
{
	int	width;

	width = ft_strlen(num);
	if (flags->width < 0)
	{
		flags->width = flags->width * -1;
		flags->minus = 1;
	}
	if (width < flags->width)
	{
		width = flags->width - width;
		if (flags->minus == 1)
		{
			flags->c_count += print_str(num);
			common_pad(width, ' ', flags);
		}
		else
			ft_check_flags(num, flags, width);
	}
	else
		flags->c_count += print_str(num);
}

char	*pad_zero(int pad)
{
	int		i;
	char	*aux;
	char	*zero;

	zero = ft_strdup("\0");
	aux = zero;
	i = 0;
	while (i < pad)
	{
		zero = ft_strjoin("0", zero);
		free (aux);
		aux = zero;
		i++;
	}
	return (zero);
}

char	*fill_zeros(char *num, int pad)
{
	char	*aux;
	char	*zero;

	zero = pad_zero(pad);
	if (!ft_strncmp(num, "-", 1))
	{
		aux = zero;
		zero = ft_strjoin("-", zero);
		free (aux);
		aux = num;
		num = ft_strdup(num + 1);
		free(aux);
	}
	aux = num;
	num = ft_strjoin(zero, num);
	free (aux);
	free (zero);
	return (num);
}
