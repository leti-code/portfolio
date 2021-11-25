/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   aux_functions.c                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/30 13:33:38 by lcasabel          #+#    #+#             */
/*   Updated: 2021/04/09 13:43:37 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "ft_printf.h"
#include "libft/libft.h"
#include <stdio.h>

int	print_str(char *s)
{
	return (write(1, s, ft_strlen(s)));
}

int	print_char(int c)
{
	return (write(1, &c, 1));
}

size_t	save_mem(long int n, int length)
{
	size_t					cont;
	unsigned long long int	num;

	cont = 0;
	if (n == 0)
		return (1);
	else if (n < 0)
	{
		num = (unsigned long long int)(n * -1);
		cont++;
	}
	else
		num = n;
	while (num != 0)
	{
		cont++;
		num = num / length;
	}
	return (cont);
}

long long int	ft_fill_mem(long long int num, char *s, char *base, int b_size)
{
	int	pos;

	pos = num % b_size;
	*s = *(base + pos);
	return (num / b_size);
}

char	*ft_itoa_base(long int n, char *base)
{
	char			*result;
	long long int	num;
	int				base_size;
	int				i;

	base_size = ft_strlen(base);
	i = save_mem(n, base_size);
	result = (char *)malloc((i + 1) * sizeof(char));
	if (!result)
		return (NULL);
	*(result + (i--)) = '\0';
	if (n < 0)
	{
		num = (long long int)n * -1;
		*(result) = '-';
	}
	else
		num = (long long int)n;
	if (n == 0)
		*(result) = *(base);
	while (num >= base_size)
		num = ft_fill_mem(num, result + (i--), base, base_size);
	num = ft_fill_mem(num, result + i, base, base_size);
	return (result);
}
