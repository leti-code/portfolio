/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_printf.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/19 11:41:17 by lcasabel          #+#    #+#             */
/*   Updated: 2021/04/08 20:06:25 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"
#include "libft/libft.h"
#include <stdio.h>

void	ft_print_data(const char c, t_flags *flags, va_list args)
{
	if (c == 'c')
		ft_print_char(va_arg(args, int), flags);
	else if (c == 's')
		ft_print_string(va_arg(args, char *), flags);
	else if (c == 'p')
		ft_print_pointer(va_arg(args, long int), flags);
	else if (c == 'd' || c == 'i')
		ft_print_decimal(va_arg(args, int), flags);
	else if (c == 'u')
		ft_print_uns_decimal(va_arg(args, unsigned int), flags);
	else if (c == 'x')
		ft_print_hexa_lower(va_arg(args, unsigned long int), flags);
	else if (c == 'X')
		ft_print_hexa_upper(va_arg(args, unsigned long int), flags);
	else if (c == '%')
		ft_print_char('%', flags);
}

int	ft_screen_param(const char *main, int pos, va_list args, int *bytes)
{
	t_flags	*flags;

	flags = NULL;
	flags = ft_init_struct(flags);
	while (*(main + pos) && ft_strchr(DATA_TYPE, *(main + pos)) == NULL)
	{
		if (ft_strchr(FLAGS, *(main + pos)) || ft_strchr(NUMBER, *(main + pos)))
			ft_complete_flags(*(main + pos), flags, args);
		else
			*bytes += print_char(*(main + pos));
		pos++;
	}
	if (ft_strchr(DATA_TYPE, *(main + pos)))
		ft_print_data(*(main + pos), flags, args);
	*bytes += flags->c_count;
	free(flags);
	return (pos);
}

int	ft_printf(const char *main, ...)
{
	va_list	args;
	int		i;
	int		*bytes;
	int		chars;

	va_start(args, main);
	i = 0;
	chars = 0;
	bytes = &chars;
	while (*(main + i))
	{
		if (*(main + i) != '%')
		{
			*bytes = *bytes + 1;
			ft_putchar_fd(*(main + i), 1);
		}
		else
		{
			i++;
			i = ft_screen_param(main, i, args, bytes);
		}
		i++;
	}
	va_end(args);
	return (*bytes);
}
