namespace Board {
	class Board {
    
    Tile[][] board;

    Board (int row, int col) {
      this.board = Tile[row][col];
    }

    void getTileValue(int row, int col) {
      return this.board[row][col];
    }
  }
}