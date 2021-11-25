/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_substr.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/26 12:57:54 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/04 18:50:17 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

char	*ft_substr(char const *s, unsigned int start, size_t len)
{
	unsigned int	i;
	char			*dest;

	if (s == NULL)
		return (NULL);
	i = 0;
	if (start > ft_strlen(s))
	{
		dest = ft_substr("\0", 0, 1);
		return (dest);
	}
	if (ft_strlen(s + start) < len)
		dest = (char *)malloc((ft_strlen(s + start) + 1) * sizeof(char));
	else
		dest = (char *)malloc((len + 1) * sizeof(char));
	if (!dest)
		return (NULL);
	while (i < len)
	{
		*(dest + i) = *(s + start + i);
		i++;
	}
	*(dest + i) = '\0';
	return (dest);
}
