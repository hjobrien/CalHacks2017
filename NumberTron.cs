namespace NumberTron {
  class Runner {
    static void Main(string[] args) {
      Player p1 = new Player();
    }
  }

  class Player {
    static int numPlayers = 0;
    string name;
    string number;
    int tailSize;
    int[] position; //x, y positions
    string direction;

    Player (string name) {
        this.name = name;
        this.number = numPlayers;
        this.numPlayers += 1;
        this.tailSize = 0;
    }

    void increaseTail() {
      this.tailSize += 1;
    }

    void spawnPlayer(int x, int y, string direction) {
      this.position = new int[] {x, y};
      this.direction = direction;
    }

    void turnLeft() {
      this.direction = "left";
    }

    void turnRight() {
      this.direction = "right";
    }

    void turnForward() {
      this.direction = "forward";
    }

    void turnBackward() {
      this.direction = "backword";
    }

    void moveAhead() {
      if (this.direction.equals("left")) {
        position[0] = position[0] - 1;
      } else if (this.direction.equals("right")) {
        position[0] = position[0] + 1;
      } else if (this.direction.equals("forward")) {
        position[1] = position[1] + 1;
      } else if (this.direction.equals("backward")) {
        position[1] = position[1] - 1;
      } else {
        Console.WriteLine("moveAhead Error") ;
        Console.ReadLine() ;
      }
    }
  }

}
