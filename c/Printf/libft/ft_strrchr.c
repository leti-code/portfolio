/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strrchr.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/23 16:28:29 by lcasabel          #+#    #+#             */
/*   Updated: 2021/02/02 19:12:35 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

char	*ft_strrchr(const char *s, int c)
{
	unsigned int	i;
	char			*aux;

	aux = (char *)s;
	i = ft_strlen(s);
	while (i > 0)
	{
		if (*(s + i) == c)
			return (aux + i);
		i--;
	}
	if (*(s + i) == c)
		return (aux + i);
	return (NULL);
}
