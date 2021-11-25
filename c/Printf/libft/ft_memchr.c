/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_memchr.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/23 12:36:28 by lcasabel          #+#    #+#             */
/*   Updated: 2021/02/02 19:01:57 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	*ft_memchr(const void *s, int c, size_t n)
{
	unsigned int	i;
	unsigned char	*aux;
	unsigned char	letter;

	aux = (unsigned char *)s;
	letter = (unsigned char)c;
	i = 0;
	while (i < n)
	{
		if ((*(aux + i)) == letter)
			return (aux + i);
		i++;
	}
	return (NULL);
}
