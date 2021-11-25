/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_itoa.c                                          :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/04 13:13:09 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/04 19:03:52 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

size_t	save_mem(int n)
{
	size_t			cont;
	unsigned int	num;

	cont = 0;
	if (n == 0)
		return (1);
	else if (n < 0)
	{
		num = (unsigned int)(n * -1);
		cont = 1;
	}
	else
		num = n;
	while (num != 0)
	{
		cont++;
		num = num / 10;
	}
	return (cont);
}

long int	fill_mem(long int num, char *s)
{
	*s = num % 10 + '0';
	return (num / 10);
}

char	*ft_itoa(int n)
{
	char		*result;
	int			i;
	long int	num;

	result = (char *)malloc((save_mem(n) + 1) * sizeof(char));
	if (!result)
		return (NULL);
	i = save_mem(n);
	*(result + (i--)) = '\0';
	if (n < 0)
	{
		num = (long int)n * -1;
		*(result) = '-';
	}
	else
		num = (long int)n;
	if (n == 0)
		*(result) = '0';
	while (num >= 10)
		num = fill_mem(num, result + (i--));
	*(result + i) = num + '0';
	return (result);
}
