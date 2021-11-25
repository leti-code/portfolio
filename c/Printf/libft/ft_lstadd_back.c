/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_lstadd_back.c                                   :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/09 16:42:50 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/04 18:45:45 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	ft_lstadd_back(t_list **lst, t_list *new)
{
	t_list	*aux;

	if (!new)
		return ;
	aux = ft_lstlast(*lst);
	if (!aux)
	{
		ft_lstadd_front(lst, new);
		return ;
	}
	aux->next = new;
	new->next = NULL;
}
