<?php   
    class Post {
        private $conn;
        private $table = 'list';

        public $id;
        public $Frage;
        public $Antwort;


        public function __construct($db){
            $this->conn = $db;
        }

        public function read(){
            $query ='SELECT 
            Frage,
            Antwort FROM '.$this->table.' ';

            $stmt = $this->conn->prepare($query);

            $stmt->execute();

            return $stmt;
        }
    }