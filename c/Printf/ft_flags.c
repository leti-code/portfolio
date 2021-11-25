/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_flags.c                                         :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/04/05 18:36:29 by lcasabel          #+#    #+#             */
/*   Updated: 2021/04/05 18:56:15 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"
#include "libft/libft.h"

void	ft_treat_zero(t_flags *flags)
{
	if (flags->width > 0 && flags->dot == 0)
		flags->width = flags->width * 10;
	else if (flags->dot == 1 && flags->precission > 0)
		flags->precission = flags->precission * 10;
	else if (flags->dot == 1)
		flags->precission = 0;
	else
		flags->zero = 1;
}

void	ft_treat_numbers(char c, t_flags *flags)
{
	if (flags->width > 0 && flags->dot == 0)
		flags->width = flags->width * 10 + (c - '0');
	else if (flags->width == 0 && flags->dot == 0)
		flags->width = c - '0';
	else if (flags->dot == 1 && flags->precission > 0)
		flags->precission = flags->precission * 10 + ((c - '0') * flags->psign);
	else if (flags->dot == 1)
		flags->precission = (c - '0') * flags->psign;
}

void	ft_complete_flags(char c, t_flags *flags, va_list args)
{
	if (c == '-')
	{
		if (flags->dot == 1)
			flags->psign = -1;
		flags->minus = 1;
	}
	else if (c == '0')
		ft_treat_zero(flags);
	else if (c == '.')
		flags->dot = 1;
	else if (c == '*')
	{
		if (flags->dot == 0)
			flags->width = va_arg(args, int);
		else
		{
			flags->precission = va_arg(args, int);
			if (flags->precission < 0)
				flags->asterisk_neg = 1;
		}
		if (flags->precission > 0 && flags->psign == -1)
			flags->precission = flags->precission * flags->psign;
	}
	else if (ft_strchr(NUMBER, c))
		ft_treat_numbers(c, flags);
}

t_flags	*ft_init_struct(t_flags *flags)
{
	flags = (t_flags *)malloc(sizeof(t_flags));
	flags->minus = 0;
	flags->zero = 0;
	flags->precission = 0;
	flags->dot = 0;
	flags->psign = 1;
	flags->asterisk_neg = 0;
	flags->width = 0;
	flags->c_count = 0;
	return (flags);
}
