/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_calloc.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/25 16:10:08 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/04 18:43:18 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	*ft_calloc(size_t count, size_t size)
{
	int		*aux;

	aux = (int *)malloc(count * size);
	if (!aux)
		return (NULL);
	ft_bzero(aux, count * size);
	return (aux);
}
