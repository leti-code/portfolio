/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strnstr.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/05 10:02:08 by lcasabel          #+#    #+#             */
/*   Updated: 2021/02/09 12:27:22 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

char	*ft_strnstr(const char *big, const char *little, size_t len)
{
	unsigned int	i;
	unsigned int	j;

	if (*(little) == '\0')
		return ((char *)big);
	if (ft_strlen(big) < ft_strlen(little))
		return (NULL);
	i = 0;
	while (i < len)
	{
		j = 0;
		while (*(big + i) != *(little + j) && i < len && *(big + i) != '\0')
			i++;
		if (*(big + i) == '\0')
			return (NULL);
		while (*(big + i) == *(little + j) && *(little + j) != '\0')
		{
			if (*(little + j + 1) == '\0' && i < len)
				return ((char *)big + i - j);
			i++;
			j++;
		}
	}
	return (NULL);
}
