using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TicTacToe : MonoBehaviour
{
    int[,] model = new int[3,3];  //0=null, 1=o, 2=x
	int turn;  //1=o, 2=x
	
	void Start(){
		reset();
	}
	
	void reset(){
		for(int i=0; i<3; i++){
			for(int j=0; j<3; j++){
				model[i,j]= 0;
			}
		}
		turn = 1;
	}
	
	int changeTurn(){
		return 3-turn;
	}
	
	void Update(){
		
	}
	
	void Model(){
		for(int i=0; i<3; i++){
			for(int j=0; j<3; j++){
				if(model[i, j]==1)
					GUI.Button(new Rect(i*80, j*80, 80, 80), "1");
				if(model[i, j]==2)
					GUI.Button(new Rect(i*80, j*80, 80, 80), "2");
				if(GUI.Button(new Rect(i*80, j*80, 80, 80), "")){
					if(turn==1)
						model[i,j] = 1;
					else
						model[i,j] = 2;
					check();
					turn = changeTurn();
				}
			}
		}
	}
	
	void check(){
		int result=0;
		for (int i=0; i<3; ++i) {    
            if (model[i,0]!=0 && model[i,0]==model[i,1] && model[i,1]==model[i,2]) {    
                result = model[i,0];    
            }    
        }    
        for (int j=0; j<3; ++j) {    
            if (model[0,j]!=0 && model[0,j]==model[1,j] && model[1,j]==model[2,j]) {    
                result = model[0,j];    
            }    
        }    
        if (model[1,1]!=0 &&    
            model[0,0]==model[1,1] && model[1,1]==model[2,2] ||    
            model[0,2]==model[1,1] && model[1,1]==model[2,0]) {    
            result = model[1,1];    
        }
        int count=0;
        for(int i=0; i<3; i++){
			for(int j=0; j<3; j++){
				if(model[i,j]!=0)
					count++;
			}
		}
		if(result==1){
			Debug.Log("O is win!");  
			reset();
		}
		if(result==2){
			Debug.Log("X is win!"); 
			reset();
		}
		if(result==0 && count==9){
			Debug.Log("Noone wins the game!"); 
			reset();
		}
	}
	
	void OnGUI(){
		Model();
	}
}

//https://blog.csdn.net/peanutdo1t/article/details/79706261
