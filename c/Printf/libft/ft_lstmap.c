/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_lstmap.c                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/10 17:07:33 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/04 18:47:24 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

t_list	*ft_lstmap(t_list *lst, void *(*f)(void *), void (*del)(void *))
{
	t_list	*aux;
	t_list	*newlst;
	t_list	*result;

	if (!(lst) || !(*f))
		return (NULL);
	aux = lst;
	result = 0;
	while (aux)
	{
		newlst = ft_lstnew((*f)(aux->content));
		if (!newlst)
		{
			ft_lstclear(&newlst, del);
			return (NULL);
		}
		ft_lstadd_back(&result, newlst);
		aux = aux->next;
	}
	return (result);
}
