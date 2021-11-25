/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   get_next_line.c                                    :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/02/20 18:14:10 by lcasabel          #+#    #+#             */
/*   Updated: 2021/03/05 19:23:51 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "get_next_line_bonus.h"
#include <stdio.h>

int	ret_line(char **excess, char **line)
{
	int		i;
	char	*aux;

	i = 0;
	while (*(*excess + i) && *(*excess + i) != '\n')
		i++;
	aux = *excess;
	*line = ft_substr(*excess, 0, i);
	*excess = ft_substr(*excess, i + 1, ft_strlen(*excess) - i - 1);
	free(aux);
	aux = 0;
	return (1);
}

int	end_of_file(char **line, char **excess)
{
	*line = *excess;
	*excess = 0;
	return (0);
}

int	read_and_fill(int fd, char **excess, char **line)
{
	int		end;
	char	aux[BUFFER_SIZE + 1];
	char	*temp;
	char	*aux2;

	aux[0] = '\0';
	*line = NULL;
	while (!(ft_strchr(aux, '\n')))
	{
		end = read(fd, aux, BUFFER_SIZE);
		if (end < 0)
			return (-1);
		aux[end] = '\0';
		if (*excess == NULL)
			*excess = ft_strdup("");
		aux2 = *excess;
		temp = ft_strjoin(*excess, aux);
		free(aux2);
		*excess = NULL;
		*excess = temp;
		if (end == 0)
			return (end_of_file(line, excess));
	}
	return (ret_line(excess, line));
}

int	ret_excess(char **excess, char **line, int fd)
{
	int			l;
	int			i;
	char		*help;

	i = 0;
	while (*(*(excess + fd) + i) != '\n')
		i++;
	help = *(excess + fd);
	*line = ft_substr(*(excess + fd), 0, i);
	l = ft_strlen(*(excess + fd));
	*(excess + fd) = ft_substr(*(excess + fd), i + 1, l - i - 1);
	free(help);
	return (1);
}

int	get_next_line(int fd, char **line)
{
	static char	*excess[4096];

	if (fd == -1 || fd > FOPEN_MAX || line == 0 || BUFFER_SIZE <= 0)
		return (-1);
	*line = NULL;
	if (*(excess + fd) != NULL)
	{
		if (ft_strchr(*(excess + fd), '\n'))
			return (ret_excess(excess, line, fd));
	}
	return (read_and_fill(fd, (excess + fd), line));
}
