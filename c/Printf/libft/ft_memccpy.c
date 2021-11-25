/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memccpy.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/22 15:22:58 by lcasabel          #+#    #+#             */
/*   Updated: 2021/02/13 18:48:07 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	*ft_memccpy(void *dest, const void *src, int c, size_t n)
{
	size_t			i;
	unsigned char	*aux;
	unsigned char	*origin;

	aux = (unsigned char *)dest;
	origin = (unsigned char *)src;
	i = 0;
	while (i < n)
	{
		(*(aux + i)) = (*(origin + i));
		if (*(origin + i) == (unsigned char)c)
			return (dest + i + 1);
		i++;
	}
	return (NULL);
}
