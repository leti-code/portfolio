/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_strtrim.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/26 16:40:59 by lcasabel          #+#    #+#             */
/*   Updated: 2021/02/05 10:38:21 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

char	*ft_strtrim(char const *s1, char const *set)
{
	unsigned int	start;
	unsigned int	end;
	char			*result;

	start = 0;
	end = ft_strlen(s1);
	while (ft_strchr(set, *(s1 + start)) && *(s1 + start) != '\0')
		start++;
	if (*(s1 + start) == '\0')
	{
		result = ft_substr("\0", 0, 1);
		return (result);
	}
	while (ft_strchr(set, *(s1 + end - 1)))
		end--;
	result = ft_substr(s1, start, (end - start));
	return (result);
}
