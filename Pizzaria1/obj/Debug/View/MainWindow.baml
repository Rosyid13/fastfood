   M S B A M L   `   `   `  ����C  ?Fastfood, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Pizzaria1	Pizzaria1  5   	       FastFood.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Pizzaria1     5   	   U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5      $
��1024��6'     � WindowStartupLocation$  CenterScreen=�64    � 
ResizeMode$ NoResize=�6Y    � WindowStyle$
 None=�6o   .��5	      � -   5        ���	#FFEEEEEE.+�5
   
   �� $	��Top=�6   .+�5      � ���	#FF0069C0$��10��6*   � 5      $��5q�6   .+�5      �� $��Center=�6    �� Orientation$ 
Horizontal=�6:   .+�5      �� $��30��6   $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=null]]   Kind$ FacebookBox=�62   5      �� 5      $��30��6   $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5        $ 
TwitterBox=�62   5      �� 5      $��30��6   $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5        $ 	GithubBox=�62   5      5      �� 5      $ 
Horizontal=�6   $��Right=�66   $
��10 0q�6R   .+�5      �� $��30��6   $��30��6(   $��0q�6a   
���������64   Z� ��6J   Z� .��5        $ BellOutline=�62   5      �� 5      $��30��6   $��30��6(   $��0q�6a   
�������$��0 0 10 0q�6   ��64   Z� ��6J   Z� .��5        $ Settings=�62   5      �� 5      -   5         ��Name$ ButtonFechar��5      $��30��63   $��30��6>   $��0q�6w   
���������6J   Z� ��6`   Z� .��5         $ Power=�62   5!      5"      5#      5$      � 5&   
   $��
250 55 0 0q�6   .+�5'      � -   5         �Name$ GridPrincipal��5'      $��Center=�6*   $��Center=�6G   5(      � 5*   
   $	��250��6   $
��Left=�6   ���	#FF222222.+�5+      ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5          Name$ TrainsitionigContentSlide��5+   2   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6U   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+	   Duration$	 0:0:0.2X�.��5,      � -   5        $ 
GridCursor��5,      $��	0 100 0 0q�6+   ���	#FF0069C0$��10��6U   $
��Left=�6`   $��60��6{   $	��Top=�6�   5-      �� 5.      -   5        
 ��Name$
 ListViewMenu��5.      $��0 100q�6-   
�������$��Champagne & Limousines)�6S   $��18(�6{    �� SelectedIndex$ 0��6�   .@�5/      �� -   5        $��60��5/      .��50      �� $ 
Horizontal=�6!   .+�51        $
 Home=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 52      $
��Home��6$   $��17(�60   $��Center=�6>   $
��20 0q�6Y   53      54      �� 55      $��60��6   .��56      �� $ 
Horizontal=�6!   .+�57        $ FoodForkDrink=�62   $��30��6G   $��30��6R   $��Center=�6^   $��5q�6y   �� 58      $��
Menu Makan��6$   $��17(�66   $��Center=�6D   $
��20 0q�6_   59      5:      �� 5;      $��60��6   .��5<      �� $ 
Horizontal=�6!   .+�5=        $
 Cash=�62   $��30��6>   $��30��6I   $��Center=�6U   $��5q�6p   �� 5>      $��Pesan��6$   $��17(�61   $��Center=�6?   $
��20 0q�6Z   5?      5@      �� 5A      $��60��6   .��5B      �� $ 
Horizontal=�6!   .+�5C        $ FormatListBulleted=�62   $��30��6L   $��30��6W   $��Center=�6c   $��5q�6~   �� 5D      $��Daftar Pesanan��6$   $��17(�6:   $��Center=�6H   $
��20 0q�6c   5E      5F      5G      5H      5J      5K      