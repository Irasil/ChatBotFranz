   M S B A M L   `   `   `  ????C  ?FranzBot, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:FranzBotFranzBot  5   	       FranzBot.API   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:FranzBot     5   	     ? Title$  API Verbindung??5   	   $	??380??6    $	??572??6-   .??5	      ?  ? ColumnDefinitions 5
   
   ?? 5      $
??106* ?6   ?? 5      $	??37* ?6    ? RowDefinitions 5   
   ?? 5      $	??35* ?6   ?? 5      $
??114* ?6   ?? 5      $
??138* ?6   ?? 5      $	??77* ?6   .+?5   
   ?? -   5         ??Name$ label??5      $??API Adresse??6   $
??Left=?65   $??	33,29,0,0q?6P   $	??Top=?6c   $??2??6{   $??26??6?   $	??104??6?   ?? 5   
   -   5         ??Name$ 	textBlock??5      $
??Left=?6'   $??
22,35,0,22q?6C   $
??Wrap=?6W   $??20(?6l   $	??284??6z   $??1??6?   ?? 6?   $?
Verbindung??6?   ?? 6?   $? ??6?   ?? 6?    ? Language$ de-ch?6?   $?zu einer API??6?   ?? 6?   $? ??6?   6?   ?? 5   
   -   5         ??Name$ 
tb_apiname??5      $
??Left=?6&   $??Center=?6A   $??	33,51,0,0q?6c    ?? TextWrapping$
 Wrap=?6v   $	??Top=?6?   $	??339??6?   $??2??6?   $??32??6?   $??10(?6?   ?? 5   
   -   5         ??Name$ btn_api??5      $??Ok??6"   $??Center=?6/   $??Center=?6L   $??3??6g   $??1??6t   $??38??6?   $??20??6?   ?? 5   
   -   5        $ label1??5      $c??]Pfad zum lokalen read.php
Beispiel: http://127.0.0.1:8080/php_rest_chatbot/api/post/read.php??6    $
??Left=?6?   $??3??6?   $??Center=?6?   $??10(?6?   $??38??6?   $	??322??6?   $??33,0,0,0q?6?   5      5      