/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   t_strdup.c                                         :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/25 17:44:04 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/04 18:51:14 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

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
