/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_printf.h                                        :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: lcasabel <marvin@42.fr>                    +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/19 11:42:39 by lcasabel          #+#    #+#             */
/*   Updated: 2021/04/07 11:25:04 by lcasabel         ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#ifndef FT_PRINTF_H
# define FT_PRINTF_H
# ifndef FLAGS
#  define FLAGS "-0.*"
# endif
# ifndef DATA_TYPE
#  define DATA_TYPE "cspdiuxX%"
# endif
# ifndef NUMBER
#  define NUMBER "0123456789"
# endif
# ifndef HEXA
#  define HEXA "0123456789abcdef"
# endif
# ifndef HEXA_UPPER
#  define HEXA_UPPER "0123456789ABCDEF"
# endif
# include <stdarg.h>

int		ft_printf(const char *main, ...);

typedef struct s_flags
{
	int		minus;
	int		zero;
	int		precission;
	int		psign;
	int		dot;
	int		asterisk_neg;
	int		width;
	int		c_count;
}	t_flags;

t_flags	*ft_init_struct(t_flags *flags);
int		print_str(char *s);
int		print_char(int c);
void	ft_complete_flags(char c, t_flags *flags, va_list args);
void	ft_print_data(const char c, t_flags *flags, va_list args);
void	ft_print_number(char *num, t_flags *flags);
void	ft_print_char(int c, t_flags *flags);
void	ft_print_string(char *s, t_flags *flags);
void	ft_print_pointer(long int n, t_flags *flags);
void	ft_print_decimal(int n, t_flags *flags);
void	ft_print_uns_decimal(unsigned int n, t_flags *flags);
void	ft_print_hexa_lower(unsigned int n, t_flags *flags);
void	ft_print_hexa_upper(unsigned int n, t_flags *flags);
void	common_pad(int width, char pad, t_flags *flags);
char	*ft_itoa_base(long int n, char *base);
char	*fill_zeros(char *num, int pad);
#endif
