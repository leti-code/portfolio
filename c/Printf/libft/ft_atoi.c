/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_atoi.c                                          :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/01/24 18:58:59 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/04 18:42:29 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

int	ft_isspace(const char c)
{
	if (c == ' ' || c == '\n' || c == '\t')
		return (1);
	if (c == '\v' || c == '\f' || c == '\r')
		return (1);
	return (0);
}

int	ft_atoi(const char *str)
{
	int	i;
	int	num;
	int	sign;

	i = 0;
	num = 0;
	sign = 1;
	while (ft_isspace(*(str + i)))
		i++;
	if (*(str + i) == '-' || *(str + i) == '+')
	{
		if (*(str + i) == '-')
			sign = -1;
		i++;
	}
	while (ft_isdigit(*(str + i)))
	{
		num = num + (*(str + i) - '0');
		if (ft_isdigit(*(str + i + 1)))
			num = num * 10;
		i++;
	}
	return (num * sign);
}
