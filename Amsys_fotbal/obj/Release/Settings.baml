   M S B A M L   `   `   `  ���� G  CAmsys_fotbal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Amsys_fotbalAmsys_fotbal      Amsys_fotbal.Settings   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:Amsys_fotbal       � Title$*  $Amysys - slovní fotbal - nastavení��$	��450��$	��800��.��(�  (� StretchDirection$
 Both=� (� Stretch$ Uniform=�.���  � RowDefinitions �� $	��23* ��� $	��51* ��� $	��71* ��� $	��85* ��� $	��98* ��� $	��91* � � ColumnDefinitions �� $	��85* ��� $	��650 ��� $	��57* �.+��� $��Nastavení hry��$��1��$��Center=�$��0,10,0,0q�$��1��$	��Top=�$��Verdana)�$��24(�$
��auto��$
��auto��$
��Bold"��� $��Spojovat slova podle:��$��1��$��Center=�$��199,0q�$��2��$	��Top=�$��Verdana)�$��20(�$
��Bold"�$��34��$	��252���� -   $��CheckBoxLetter��$��Poslední písmeno��$��1��$
��Left=�$��	10,33,0,0q�$��2��$	��Top=�$��33��$	��191��$��Verdana)�$��20(��� -   $��CheckBoxTwoLetter��$��Poslední dvě písmena��$��1��$
��Left=�$��
205,33,0,0q�$��2��$	��Top=�$��29��$	��248��$��Verdana)�$��20(��� -   $��CheckBoxSyllable��$��Poslední slabika��$��1��$
��Left=�$��
449,34,0,0q�$��2��$	��Top=�$��33��$	��191��$��Verdana)�$��20(�$��2���� $ ��Opakovat použitá slova?:��$��1��$
��Left=�$��
168,10,0,0q�$��3��$	��Top=�$��Verdana)�$��20(�$
��Bold"�$��34��$	��305��	� -   $��RadioYes��$	��Ano��$��1��$
��Left=�$��
219,49,0,0q�$��3��$	��Top=�$��Verdana)�$��20(�$��23��$��57��	� -   $��RadioNo��$��Ne�� d� 	IsChecked$
 TrueY�$��1��$��Right=�$��
0,53,200,8q�$��3��$��Center=�$��Verdana)�$��20(�$��24��$��46���� $��Jaký použít slovník?:��$��1��$��Center=�$��205,0q�$��4��$	��Top=�$��Verdana)�$��20(�$
��Bold"�$��34��$	��240���� -   $��ButtonDefault��$��	Výchozí��$��1��$
��Left=�$��168,42,0,28q�$��4��$��Center=�$	��101��$��Verdana)�$��20(�$��28���� -   $��ButtonCustom��$��Vlastní��$��1��$��Right=�$��0,42,177,28q�$��4��$��Center=�$	��103��$��Verdana)�$��20(�$��28���� $<��6(soubor .txt  Slova oddělena mezarami nebo čárkami)��$��1��$
��Left=�$��	279,0,0,0q�$��4��$��Bottom=�$��26��$	��291���� -   $��ButtonFinished��$��Hotovo!��$��1��$��Center=�$��0,0,0,0q�$��5��$��Center=�$	��139��$��Verdana)�$��24(�