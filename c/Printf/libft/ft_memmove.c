/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memmove.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/22 15:42:33 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/19 11:53:40 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	*ft_memmove(void *dest, const void *src, size_t n)
{
	unsigned int	i;
	char			*aux;
	char			*origin;
	const int		TAM = n;
	char			array[TAM];

	aux = (char *)dest;
	origin = (char *)src;
	i = 0;
	while (i < n)
	{
		array[i] = (*(origin + i));
		i++;
	}
	i = 0;
	while (i < n)
	{
		(*(aux + i)) = array[i];
		i++;
	}
	return (dest);
}
