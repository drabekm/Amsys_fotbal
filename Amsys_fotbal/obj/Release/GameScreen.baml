   M S B A M L   `   `   `  ���� G  CAmsys_fotbal, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Amsys_fotbalAmsys_fotbal      Amsys_fotbal.GameScreen   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     ,localclr-namespace:Amsys_fotbal       � Title$  
GameScreen��$	��450��$	��800��.��(�  (� StretchDirection$
 Both=� (� Stretch$ Uniform=�.���  � RowDefinitions �� $
��321* ��� $	��87* ��� $	��11* � � ColumnDefinitions �� $
��125* ��� $	��55* ��� $	��18* �.+��� $��Aktuální hráč:��$��1��$��Center=�$��0,10,0,0q�$	��Top=�$��Verdana)�$��18(��� -   $��LabelCurrent��$��Aktuální hráč:��$��1��$��Center=�$��0,36,0,0q�$	��Top=�$��Verdana)�$��18(�$
��Bold"��� $��Další hráč:��$��1��$��Center=�$��0,81,0,0q�$	��Top=�$��Verdana)�$��18(��� -   $��	LabelNext��$��Další hráč:��$��1��$��Center=�$��	0,104,0,0q�$	��Top=�$��Verdana)�$��18(�$
��Bold"��� -   $��	TextInput��$
��Left=�$��67��$��	10,10,0,0q�$��1�� �� TextWrapping$
 Wrap=�$��TextBox��$	��Top=�$	��480��$��Verdana)�$��22(�$
��Left=�$��Center=��� -   $��ButtonGiveUp��$��	Vzdát se��$��1��$
��Left=�$��
10,164,0,0q�$	��Top=�$	��200��$��Verdana)�$��22(� J� RenderTransformOrigin$ 
0.12,2.706&�$��71���� -   $��
ButtonHelp��$��
Nápověda��$��1��$
��Left=�$��
10,240,0,0q�$	��Top=�$	��200��$��Verdana)�$��22(�$ 
0.12,2.706&�$��71���� -   $��ButtonInput��$��Zadat slovo��$
��Left=�$��	10,10,0,0q�$	��Top=�$	��200��$��Verdana)�$��22(�$ 
0.12,2.706&�$��71��$��1��$��1���� $��Předchozí slovo:��$
��Left=�$��
10,104,0,0q�$	��Top=�$��Verdana)�$��18(�$
��Bold"��� -   $��LabelPreviousWord��$��--zatím žádné--��$
��Left=�$��191,104,0,0q�$	��Top=�$��Verdana)�$��18(�$
��Bold"��� $��Předchozí písmeno:��$
��Left=�$��
10,170,0,0q�$	��Top=�$��Verdana)�$��14(��� -   $��LabelPreviousLetter��$��--zatím žádné--��$
��Left=�$��163,170,0,0q�$	��Top=�$��Verdana)�$��14(����	#FFFF3939�� $��Předchozí 2 písmena:��$
��Left=�$��
10,201,0,0q�$	��Top=�$��Verdana)�$��14(��� -	   $��LabelPreviousTwoLetter��$��--zatím žádné--��$
��Left=�$��177,201,0,0q�$	��Top=�$��Verdana)�$��14(����	#FFFF3939�� $��Předchozí slabika:��$
��Left=�$��
10,232,0,0q�$	��Top=�$��Verdana)�$��14(��� -
   $��LabelPreviousSyllable��$��--zatím žádné--��$
��Left=�$��152,232,0,0q�$	��Top=�$��Verdana)�$��14(����	#FFFF3939