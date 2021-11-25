/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strjoin.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/26 13:41:23 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/04 18:51:43 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

char	*ft_strjoin(char const *s1, char const *s2)
{
	unsigned int	i;
	unsigned int	j;
	char			*result;

	i = 0;
	j = 0;
	result = (char *)malloc((ft_strlen(s1) + ft_strlen(s2) + 1) * sizeof(char));
	if (!result)
		return (NULL);
	while (*(s1 + i) != '\0')
	{
		*(result + i) = *(s1 + i);
		i++;
	}
	while (*(s2 + j) != '\0')
	{
		*(result + i + j) = *(s2 + j);
		j++;
	}
	*(result + i + j) = '\0';
	return (result);
}
