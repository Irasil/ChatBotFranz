<?php

use LDAP\Result;

 
    header('Content-Type: application/json');

    include_once '../../config/Database.php';
    include_once '../../models/Post.php';

    $database = new Database();
    $db = $database->connect();

    $post = new Post($db);

    $result = $post->read();

    $num = $result->rowCount();

    if($num > 0){
        $posts_arr = array();
        $posts_arr['Keywords'] = array();

        while($row = $result->fetch(PDO::FETCH_NAMED)){
            extract($row);
            $post_item = array(
                'Frage' => $Frage,
                'Antwort' => $Antwort,
            );

            array_push($posts_arr['Keywords'], $post_item);
        }

        echo json_encode($posts_arr);

    }else{
        echo json_encode(
            array('message' => 'Kein Posts gefunden')
        );
    }
