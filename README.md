# TicTacToe
#本次实验参考https://blog.csdn.net/peanutdo1t/article/details/79706261

本次实验ECS架构的体现：其中Entity为model[，]这个3x3的的数组，代表了棋盘，0代表无棋子，1代表o棋子，2代表x棋子；Component为reset()，changeTurn()，Model()，check()这几个函数，本身这几个函数不具有数据，通过对Entity的操作后使棋盘可以开始下棋；System是OnGUI()函数，实现交互与呈现。
