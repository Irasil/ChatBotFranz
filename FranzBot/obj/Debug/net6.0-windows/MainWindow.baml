   M S B A M L   `   `   `  ????C  ?FranzBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ChatBotChatBot  5   	       FranzBot.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:ChatBot     5   	     ? Title$  FranzBot??5   	   $	??750??6   $
??1000??6'    ? WindowStartupLocation$ CenterScreen=?5	   	   
???????.??5      ?  ? RowDefinitions 5   
   ?? 5      $	??41* ?6   ?? 5      $
??542* ?6   ?? 5      $	??29* ?6   ?? 5      $
??122* ?6    ? ColumnDefinitions 5   
   ?? 5      $	??33* ?6   ?? 5      $
??824* ?6   ?? 5      $
??113* ?6   ?? 5      $	??30* ?6   .+?5   
   ]? $??4??6   $??3??6(   .+?5      o? $	??Top=?6   
???????.@?5      m? $??_File??6   .@?5      m? -   5        $??_Open??5      6.   m? 5      -   5        $??_Open SQL Connection??5      6=   m? 5      -   5        $??_Open API Connection??5      6=   m? 5      -   5        $??_Save as Log??5      65   ?? 5       m? 5!      -   5        $??_Exit??5!      6.   5"      m? 5#      $??_Edit??6   .@?5$      m? -   5        $??Add Keyword??5$      64   5%      m? 5&      -   5        $??_About??5&      5(      5)      ?? 5*       ?? AcceptsReturn$
 True??6   $??0q?6+    ?? 
IsReadOnly$
 True??6?   
???iii?6S   5+      ?? 5,   
   -   5         ??Name$
 send??5,      $
??Send??6    ?? 	IsDefault$
 True??6.   $??Center=?6?   $??3??6Z   $??16(?6g   $??30??6u   $??	10,0,11,0q?6?   
???????$??2??6?   ?? 5-   
   -	   5         ??Name$ textBox??5-      $??Center=?6#   $??7,0,10,0q?6E   	 ?? TextWrapping$
	 Wrap=?6W   $??Center=?6k   $??30??6?   $??3??6?   $??1??6?   ?? 5.   
   -
   5        $ textBox1??5.      $??Visible=?6$   $??Center=?6W   $
	 Wrap=?6t   $	??Top=?6?   $	??920??6?   $	??500??6?   $??1??6?   $??2??6?   $??0,15,0,0q?6?   $??1??6?   50      51      