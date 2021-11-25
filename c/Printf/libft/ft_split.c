/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_split.c                                         :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/26 16:57:36 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/04 18:55:43 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

size_t	count_words(char const *s, char c)
{
	unsigned int	i;
	unsigned int	count;

	count = 0;
	i = 0;
	while (*(s + i) == c && *(s + i) != '\0')
		i++;
	while (*(s + i) != '\0')
	{
		if (*(s + i) != c && (*(s + i + 1) == c || *(s + i + 1) == '\0'))
			count++;
		i++;
	}
	return (count);
}

size_t	get_pos(char const *s, char c)
{
	unsigned int	i;

	i = 0;
	while (*(s + i) != c && *(s + i) != '\0')
		i++;
	return (i);
}

char	**free_the_string(char **result, int i)
{
	while (--i >= 0)
		free(result[i]);
	return (result);
}

char	**ft_split(char const *s, char c)
{
	char			**result;
	char			*aux;
	unsigned int	i;
	unsigned int	j;

	aux = (char *)s;
	i = 0;
	j = 0;
	result = (char **)malloc((count_words(s, c) + 1) * sizeof(char *));
	if (!result)
		return (NULL);
	while (i < count_words(s, c))
	{
		while (*(aux + j) == c && *(aux + j) != '\0')
			j++;
		if (!(*(result + i) = ft_substr(aux, j, get_pos((aux + j), c))))
			return (free_the_string(result, i));
		j = j + get_pos((aux + j), c);
		i++;
	}
	*(result + i) = 0;
	return (result);
}
