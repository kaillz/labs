   M S B A M L   `   `   `  ����?  ;zil1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:zil1zil1  5   	       zil1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   $localclr-namespace:zil1     5   	     � Title$%  Система омофонов��5   	   $	��640��6"   $	��480��6/    � WindowStyle$ ThreeDBorderWindow=�6;   .��5	      � -   5         �Name$ MainWin��5	      .+�5
   
   �� -   5         ��Name$ input��5
      $��0,44,0,0q�6!    �� TextWrapping$
 Wrap=�63   $	��440��6G   $��40��6S   $	��Top=�6_   $��18(�6w   �� 5   
   -   5        $ output��5      $��	0,184,0,0q�6"   $
 Wrap=�65   $	��Top=�6I   $	��440��6a   $	��180��6m   $��18(�6z   �� 5   
   -   5         ��Name$ encrypt��5      $��ЗАШИФРОВАТЬ��6"   $��	0,104,0,0q�68   $	��Top=�6K   $��40��6c   $	��440��6o   $��20(�6�   $
��Bold"�6�    J� Effect 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      5      �� 5   
   $��Введите фразу��6   $��	20,4,20,0q�6(   $	��Top=�6;   $��40��6S   $	��440��6_   $��Arial)�6k   $��20(�6~    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��Center=�6�   $��Center=�6�   z�5      V� 5      .~�5      �� �� 5      �� 5      T� 5      5      5      �� 5   
   $'��!Зашифрованный вид��6   $	��Top=�6,   $��40��6D   $	��440��6P   $��Arial)�6\   $��20,144,20,0q�6o   $��Center=�6�   $��Center=�6�   $��20(�6�   �� 5   
   -   5        $ decrypt��5      $��ДЕШИФРОВАТЬ��6"   $��20,404,20,0q�68   $	��Top=�6M   $��40��6e   $	��440��6q   $��20(�6�   $
��Bold"�6�    5        5      5       �� 5!   
   -   5        $ decrypttext��5!      $��20,484,20,0q�6'   $
 Wrap=�6<   $	��440��6P   $��80��6\   $	��Top=�6h   $��18(�6�   5#      5$      