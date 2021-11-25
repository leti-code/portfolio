/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line_utils.c                              :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/22 09:04:39 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/05 17:20:16 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "get_next_line_bonus.h"

size_t	ft_strlen(const char *s)
{
	size_t	cont;

	cont = 0;
	while (*(s + cont) != '\0')
		cont++;
	return (cont);
}

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

char	*ft_substr(char const *s, unsigned int start, size_t len)
{
	unsigned int	i;
	char			*dest;
	size_t			l;

	if (s == NULL)
		return (NULL);
	i = 0;
	if (start > ft_strlen(s))
		return (ft_substr("\0", 0, 1));
	l = ft_strlen(s + start);
	if (l < len)
		dest = (char *)malloc((l + 1) * sizeof(char));
	else
		dest = (char *)malloc((len + 1) * sizeof(char));
	if (!dest)
		return (NULL);
	while (i < len && (*(s + start + i)))
	{
		*(dest + i) = *(s + start + i);
		i++;
	}
	*(dest + i) = '\0';
	return (dest);
}

char	*ft_strdup(const char *s)
{
	char	*aux;
	size_t	i;

	i = 0;
	aux = (char *)malloc((ft_strlen(s) + 1) * sizeof(char));
	if (!aux)
		return (NULL);
	while (*(s + i) != '\0')
	{
		*(aux + i) = *(s + i);
		i++;
	}
	*(aux + i) = '\0';
	return (aux);
}

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
