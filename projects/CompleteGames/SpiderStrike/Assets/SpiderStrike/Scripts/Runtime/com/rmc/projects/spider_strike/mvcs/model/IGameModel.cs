/**
 * Copyright (C) 2005-2014 by Rivello Multimedia Consulting (RMC).                    
 * code [at] RivelloMultimediaConsulting [dot] com                                                  
 *                                                                      
 * Permission is hereby granted, free of charge, to any person obtaining
 * a copy of this software and associated documentation files (the      
 * "Software"), to deal in the Software without restriction, including  
 * without limitation the rights to use, copy, modify, merge, publish,  
 * distribute, sublicense, and#or sell copies of the Software, and to   
 * permit persons to whom the Software is furn
 * 
 * ished to do so, subject to
 * the following conditions:                                            
 *                                                                      
 * The above copyright notice and this permission notice shall be       
 * included in all copies or substantial portions of the Software.      
 *                                                                      
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,      
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF   
 * MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
 * IN NO EVENT SHALL THE AUTHORS BE LIABLE FOR ANY CLAIM, DAMAGES OR    
 * OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE,
 * ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
 * OTHER DEALINGS IN THE SOFTWARE.                                      
 */
// Marks the right margin of code *******************************************************************

//--------------------------------------
//  Imports
//--------------------------------------
using com.rmc.projects.spider_strike.mvcs.controller.signals;
using com.rmc.projects.spider_strike.mvcs.model.vo;

//--------------------------------------
//  Namespace
//--------------------------------------
namespace com.rmc.projects.spider_strike.mvcs.model
{
	
	//--------------------------------------
	//  Class
	//--------------------------------------
	public interface IGameModel
	{
		
		//--------------------------------------
		//  Properties
		//--------------------------------------
		// GETTER / SETTER
		/// <summary>
		/// Gets or sets the turret health changed signal.
		/// </summary>
		/// <value>The turret health changed signal.</value>
		TurretHealthChangedSignal turretHealthChangedSignal { get; set;}

		/// <summary>
		/// Gets or sets the turret health.
		/// </summary>
		/// <value>The turret health.</value>
		int turretHealth { set; get;}

		/// <summary>
		/// Gets or sets the score.
		/// </summary>
		/// <value>The score.</value>
		float score { set; get;}

		/// <summary>
		/// Gets or sets the current round data V.
		/// </summary>
		/// <value>The current round data V.</value>
		RoundDataVO currentRoundDataVO { set; get;}

		/// <summary>
		/// Gets or sets the state of the game.
		/// </summary>
		/// <value>The state of the game.</value>
		GameState gameState { set; get;}


		//--------------------------------------
		//  Methods
		//--------------------------------------

		/// <summary>
		/// Dos the reset model.
		/// </summary>
		void doResetModel();

		/// <summary>
		/// Hases the next round.
		/// </summary>
		/// <returns><c>true</c>, if next round was hased, <c>false</c> otherwise.</returns>
		bool hasNextRound();

		/// <summary>
		/// Starts the next round.
		/// </summary>
		void doRoundStart ();
		
	}
}

