/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strchr.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/23 16:17:28 by lcasabel          #+#    #+#             */
/*   Updated: 2021/02/02 19:10:10 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

char	*ft_strchr(const char *s, int c)
{
	int		i;
	char	*aux;

	i = 0;
	aux = (char *)s;
	while (*(s + i) != '\0')
	{
		if (*(s + i) == c)
			return (aux + i);
		i++;
	}
	if (*(s + i) == c)
		return (aux + i);
	return (NULL);
}
