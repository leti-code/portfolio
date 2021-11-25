/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memcpy.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/22 13:33:47 by lcasabel          #+#    #+#             */
/*   Updated: 2021/02/02 19:07:40 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	*ft_memcpy(void *dest, const void *src, size_t n)
{
	unsigned int	i;
	char			*aux;
	char			*origin;

	aux = (char *)dest;
	origin = (char *)src;
	i = 0;
	while (i < n)
	{
		(*(aux + i)) = (*(origin + i));
		i++;
	}
	return (dest);
}
