   M S B A M L   `   `   `  ����C  ?ToDoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToDoListToDoList  5   	       ToDoList.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ToDoList     5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   
   -   5          � Title$  ToDoList��5	   	   $	��450��6   $	��800��6'   .��5
      � .+�5   
   �� .@�5      �� $��Все заметки��6   .��5      �  � DataContext 6   ��  �� ElementName$ 
dgAllNotes�� �� Path$ SelectedValue�.+�5      &   System.Windows.Controls.DataGrid  -   5          Name$ 
dgAllNotes��5      $��Italic$�6[   $��18(�6n      AutoGenerateColumns .  ��64   ��  �� Source$ myPath��   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        Date��,  &System.Windows.Controls.DataGridColumn   Header$% Создание заметки��5   ?   	   
IsReadOnly	 . 1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6Y   �� *
CreateDate+6x   4  .System.Windows.Controls.DataGridCheckBoxColumn  5      -   5        
Status��$! Статус заметки��5   F   	 .  
 6^   �� $ IsDone� �� UpdateSourceTrigger$ PropertyChanged=�6�     5      -   5        	Notes��$2 ,Описание заметки/задачи��5   @   	 .  
 6a   �� *Notes+6{   5      5      5      �� 5      $��Выполнено��6   5      �� 5      $��В процессе��6   5      5      5      5      