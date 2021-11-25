/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_lstclear.c                                      :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/10 14:53:42 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/04 18:46:20 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

void	ft_lstclear(t_list **lst, void (*del)(void *))
{
	t_list	*aux;
	t_list	*temp;

	aux = *lst;
	if (!aux)
		return ;
	while (aux)
	{
		temp = aux->next;
		(*del)(aux->content);
		free(aux);
		aux = temp;
	}
	*lst = NULL;
}
