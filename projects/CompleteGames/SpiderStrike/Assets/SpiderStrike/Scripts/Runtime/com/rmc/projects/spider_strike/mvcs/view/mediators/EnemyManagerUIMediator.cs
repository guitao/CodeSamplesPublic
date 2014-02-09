﻿/**
 * Copyright (C) 2005-2013 by Rivello Multimedia Consulting (RMC).                    
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
using strange.extensions.mediation.impl;
using com.rmc.projects.spider_strike.mvcs.view.ui;


//--------------------------------------
//  Namespace
//--------------------------------------
using com.rmc.projects.spider_strike.mvcs.controller.signals;
using UnityEngine;
using com.rmc.projects.spider_strike.mvcs.model.vo;
using com.rmc.projects.spider_strike.mvcs.model;
using System.Collections.Generic;


namespace com.rmc.projects.spider_strike.mvcs.view
{
	
	//--------------------------------------
	//  Namespace Properties
	//--------------------------------------
	
	
	//--------------------------------------
	//  Class Attributes
	//--------------------------------------
	
	
	//--------------------------------------
	//  Class
	//--------------------------------------
	public class EnemyManagerUIMediator : Mediator
	{
		
		//--------------------------------------
		//  Properties
		//--------------------------------------
		/// <summary>
		/// Gets or sets the view.
		/// </summary>
		/// <value>The view.</value>
		[Inject]
		public EnemyManagerUI view 	{ get; set;}

		/// <summary>
		/// Gets or sets the round start signal.
		/// </summary>
		/// <value>The round start signal.</value>
		[Inject]
		public RoundStartedSignal roundStartedSignal {set; get;}


		/// <summary>
		/// The enemy died signal.
		/// </summary>
		[Inject]
		public EnemyDiedSignal enemyDiedSignal {set; get;}

		// GETTER / SETTER
		/// <summary>
		/// MODEL: The main game data
		/// </summary>
		[Inject]
		public IGameModel iGameModel { get; set; } 
		
		// PUBLIC
		
		
		// PUBLIC STATIC
		
		// PRIVATE
		
		// PRIVATE STATIC
		
		//--------------------------------------
		//  Methods
		//--------------------------------------
		/// <summary>
		/// Raises the register event.
		/// </summary>
		public override void OnRegister()
		{
			//view.init();
			enemyDiedSignal.AddListener (_onEnemyDiedSignal);
			roundStartedSignal.AddListener (_onRoundStartedSignal);
			
		}
		
		/// <summary>
		/// Raises the remove event.
		/// </summary>
		public override void OnRemove()
		{
			enemyDiedSignal.RemoveListener (_onEnemyDiedSignal);
			roundStartedSignal.RemoveListener (_onRoundStartedSignal);
		}
		
		/// <summary>
		/// Start this instance.
		/// </summary>
		public void Start ()
		{



		}
		
		/// <summary>
		/// Update this instance.
		/// </summary>
		public void Update()
		{
			
			
		}
		
		//	PUBLIC
		
		
		// PRIVATE
		
		// PRIVATE STATIC
		
		// PRIVATE COROUTINE
		
		// PRIVATE INVOKE
		
		//--------------------------------------
		//  Events
		//--------------------------------------
		/// <summary>
		/// _ons the round start signal.
		/// </summary>
		/// <param name="aRoundDataVO">A round data V.</param>
		private void _onRoundStartedSignal (RoundDataVO aRoundDataVO)
		{
			//
			iGameModel.currentRoundDataVO.clearEnemies();

			//
			iGameModel.currentRoundDataVO.addEnemy ( view.doCreateSpider() );

		}

		/// <summary>
		/// _ons the enemy died signal.
		/// </summary>
		/// <param name="aEnemyThatDied_gameobject">A enemy that died_gameobject.</param>
		private void _onEnemyDiedSignal (GameObject aEnemyThatDied_gameobject)
		{

			iGameModel.currentRoundDataVO.removeEnemy (aEnemyThatDied_gameobject);
			Destroy (aEnemyThatDied_gameobject);


			//
			//Debug.Log (iGameModel.currentRoundDataVO.enemiesCreated + " and " +  iGameModel.currentRoundDataVO.enemiesTotalToCreate);
			if (iGameModel.currentRoundDataVO.enemiesCreated < iGameModel.currentRoundDataVO.enemiesTotalToCreate) {
				iGameModel.currentRoundDataVO.addEnemy (	view.doCreateSpider() 	);
			} else {

				//DONE
				Debug.Log ("done game");
			}
		}




	}
}
