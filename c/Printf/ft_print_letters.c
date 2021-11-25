/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_print_letters.c                                 :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/04/05 18:58:21 by lcasabel          #+#    #+#             */
/*   Updated: 2021/04/08 17:05:15 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"
#include "libft/libft.h"

void	pad_print_char(int c, int width, char pad, t_flags *flags)
{
	common_pad(width, pad, flags);
	flags->c_count = flags->c_count + print_char(c);
}

void	ft_print_char(int c, t_flags *flags)
{
	int	width;

	width = 1;
	if (flags->width < 0)
	{
		flags->width = -flags->width;
		flags->minus = 1;
	}
	if (flags->width > 1)
	{
		width = flags->width - width;
		if (flags->minus == 1)
		{
			flags->c_count += print_char(c);
			common_pad(width, ' ', flags);
		}
		else if (flags->zero == 1)
			pad_print_char(c, width, '0', flags);
		else
			pad_print_char(c, width, ' ', flags);
	}
	else
		flags->c_count += print_char(c);
}

void	consider_width(char *string, int width, t_flags *flags)
{
	if (width < flags->width)
	{
		width = flags->width - width;
		if (flags->minus == 1)
		{
			flags->c_count += print_str(string);
			common_pad(width, ' ', flags);
		}
		else if (flags->zero == 1)
		{
			common_pad(width, '0', flags);
			flags->c_count += print_str(string);
		}
		else
		{
			common_pad(width, ' ', flags);
			flags->c_count += print_str(string);
		}
	}
	else
		flags->c_count += print_str(string);
}

void	ft_print_string(char *s, t_flags *flags)
{
	char	*string;

	string = NULL;
	if (!s)
		s = "(null)";
	if (flags->dot == 1 && flags->asterisk_neg == 0 && flags->precission <= 0)
	{
		string = ft_strdup("\0");
		if (flags->precission < 0)
			flags->width = -flags->precission;
	}
	else if (flags->dot == 1 && flags->precission > 0)
		string = ft_substr(s, 0, flags->precission);
	else
		string = ft_substr(s, 0, ft_strlen(s));
	if (!string)
		return ;
	if (flags->width < 0)
	{
		flags->width = flags->width * -1;
		flags->minus = 1;
	}
	consider_width(string, ft_strlen(string), flags);
	free(string);
}
