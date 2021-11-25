/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strmapi.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/01 10:01:44 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/04 18:50:40 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

char	*ft_strmapi(char const *s, char (*f)(unsigned int, char))
{
	unsigned int	i;
	unsigned int	size;
	char			*result;

	size = ft_strlen(s);
	result = (char *)malloc((size + 1) * sizeof(char));
	if (!result)
		return (NULL);
	i = 0;
	while (i < size)
	{
		*(result + i) = (*f)(i, *(s + i));
		i++;
	}
	*(result + i) = '\0';
	return (result);
}
