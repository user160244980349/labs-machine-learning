   M S B A M L   `   `   `  ����   ML1    ML1.Views.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     R NOxyPlot.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=75e952ba404cdbb0$OxyPlothttp://oxyplot.org/wpf  -     � Title$  Основы ИИ��$	��500��$	��550��$	��500��$	��550��.���� $��0q�$��2��.@��� $��Обучение��.���� $"��Гиперпараметры��$��10q�.��� $��50,10q� � ColumnDefinitions �� $
��Auto ���  � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��0��$��0��$$��Нейроны 1-го слоя��$��5q�$��Center=�$��Right=��� $��0��$��1��$$��Нейроны 2-го слоя��$��5q�$��Center=�$��Right=��� $��0��$��2��$#��Количество эпох��$��5q�$��Center=�$��Right=��� $��0��$��3��$'��!Скорость обучения��$��5q�$��Center=�$��Right=��� $��0��$��4��$��Искажение��$��5q�$��Center=�$��Right=��� $��0��$��5��$��Образцы��$��5q�$��Center=�$��Right=��� -    ��Name$ X��$��1��$��0��$��16��$��5q� �� TextWrapping$
 Wrap=�$��Center=�$	��100��$��25���� -   $ Y��$��1��$��1��$��16��$��5q�$
 Wrap=�$��Center=�$	��100��$��25���� -   $ Epoches��$��1��$��2��$	��800��$��5q�$
 Wrap=�$��Center=�$	��100��$��25���� -   $ Speed��$��1��$��3��$
��0.05��$��5q�$
 Wrap=�$��Center=�$	��100��$��25���� -   $ 
LearnNoise��$��1��$��4��$	��0.2��$��5q�$
 Wrap=�$��Center=�$	��100��$��25���� $��5q�$��1��$��2��$��5�� �� Orientation$ 
Horizontal=�.+��� $��5q�$��1��$��5��$%��/ML1;component/Resources/11.png��$
��Fill=��� $��5q�$��1��$��5��$%��/ML1;component/Resources/12.png��$
��Fill=��� $��5q�$��1��$��5��$%��/ML1;component/Resources/13.png��$
��Fill=��� $��5q�$��1��$��5��$%��/ML1;component/Resources/14.png��$
��Fill=��� -   $��Обучить��$��1��$��6��$��5q�$��Center=�$��25��$	��100���� $��Тестирование��.��� $��10q� �� $
��auto ��� .+��� $��Проверка��$��0��.��� $��50,10q� �� $
��Auto ���  �� $
��Auto ��� $
��Auto ��� $
��Auto �.+��� $��1��$��0��$ 
Horizontal=�$��5q�.+�	� -    	�Name$	 Six��$��5q� d� 	IsChecked$
 TrueY�.���� $��25��$%��/ML1;component/Resources/11.png��$
��Fill=�$��25��	� -	   $ Seven��$��5q�.���� $��25��$%��/ML1;component/Resources/12.png��$
��Fill=�$��25��	� -
   $	 Zhe��$��5q�.���� $��25��$%��/ML1;component/Resources/13.png��$
��Fill=�$��25��	� -   $
 Sche��$��5q�.���� $��25��$%��/ML1;component/Resources/14.png��$
��Fill=�$��25���� $��0��$��1��$��Искажение��$��Right=�$��5q�$��Center=��� -   $ 	TestNoise��$	��0.2��$��1��$��1��$��5q��� -   $��1��$��2��$��5q�$��25��$	��100��$��Проверить��$��Bottom=��� $��0��$��Образец��$��5q�$��Right=�$��Center=��� $��Результат��$��1��.��  OxyPlot.Wpf.PlotView     Model �� *Columns.Plot+�� $#��Ошибка обучения��.��   �� *
Lines.Plot+