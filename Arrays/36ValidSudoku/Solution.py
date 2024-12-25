
class Solution:
    def isValidSudoku(self, board: List[List[str]]) -> bool:
        for i in range(0, len(board)):
            for j in range(0, len(board[0])):
                if(board[i][j] == '.'):
                    break
                value = board[i][j]
                
                #Check SubBox
                subBoxColum = int(j/3)
                subBoxFile = int(i/3)

                for k in range(0, 3):
                    for k2 in range(0, 3):
                        if(value == board[subBoxFile + k][subBoxColum + k2]):
                            return False
                
                #Check vertical
                for k in range(0, subBoxFile):
                    if(value == board[i][k]):
                        return False
                for k in range(subBoxFile + 3, len(board)):
                    if(value == board[i][k]):
                        return False
                #Check Horizontal
                for k in range(0, subBoxColum):
                    if(value == board[k][j]):
                        return False
                for k in range(subBoxColum + 3, len(board)):
                    if(value == board[k][j]):
                        return False
        return True
                
for k in range(0, 0):
    print("test")
print("end")