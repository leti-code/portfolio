/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strlcpy.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/23 13:19:28 by lcasabel          #+#    #+#             */
/*   Updated: 2021/02/08 20:15:20 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

size_t	ft_strlcpy(char *dst, const char *src, size_t size)
{
	int	i;

	i = 0;
	while (i < (int)(size - 1) && *(src + i) != '\0')
	{
		*(dst + i) = *(src + i);
		i++;
	}
	if (size > 0)
		(*(dst + i)) = '\0';
	return (ft_strlen(src));
}
