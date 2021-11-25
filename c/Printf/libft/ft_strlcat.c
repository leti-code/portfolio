/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strlcat.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/23 13:50:06 by lcasabel          #+#    #+#             */
/*   Updated: 2021/02/08 16:53:34 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

size_t	ft_strlcat(char *dst, const char *src, size_t size)
{
	unsigned int	i;

	if (size <= ft_strlen(dst))
		return (size + ft_strlen(src));
	i = ft_strlen(dst);
	while (*(src) != '\0' && (i + 1) != size)
	{
		*(dst + i) = *(src);
		src++;
		i++;
	}
	*(dst + i) = '\0';
	return (ft_strlen(dst) + ft_strlen(src));
}
