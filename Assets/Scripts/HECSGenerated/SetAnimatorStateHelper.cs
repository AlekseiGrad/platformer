﻿using System;using HECSFramework.Serialize;namespace Commands{	[Serializable]	public struct SetEllenAnimatorState : ISetAnimatorState	{		public FloatId HorizontalSpeed;		public FloatId VerticalSpeed;		public FloatId TimeOut;		public BoolId Crouching;		public BoolId Grounded;		public BoolId Pushing;		public BoolId HoldingGun;		public void SetState(AnimatorState animatorState)		{			animatorState.SetFloat(HorizontalSpeed.Id, HorizontalSpeed.Value);			animatorState.SetFloat(VerticalSpeed.Id, VerticalSpeed.Value);			animatorState.SetFloat(TimeOut.Id, TimeOut.Value);			animatorState.SetBool(Crouching.Id, Crouching.Value);			animatorState.SetBool(Grounded.Id, Grounded.Value);			animatorState.SetBool(Pushing.Id, Pushing.Value);			animatorState.SetBool(HoldingGun.Id, HoldingGun.Value);		}	}	[Serializable]	public struct SetEllenCutsceneImageAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetEllenDeathEffectAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetEllenHurtEffectAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetEllenPushAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetChomperAnimatorState : ISetAnimatorState	{		public BoolId Grounded;		public BoolId Melee;		public void SetState(AnimatorState animatorState)		{			animatorState.SetBool(Grounded.Id, Grounded.Value);			animatorState.SetBool(Melee.Id, Melee.Value);		}	}	[Serializable]	public struct SetGunnerAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetGunnerBeamEffectAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetGunnerIntroCutsceneCharacterAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetGunnerIntroCutsceneDoorAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetSpitterAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetBridgeAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetDoorSpriteAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetKeyAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetPushableBoxSwitchAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetTeleporterAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetGunnerUIHealthAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetGunnerUIShieldAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetDialogueCanvasAnimatorState : ISetAnimatorState	{		public BoolId Active;		public void SetState(AnimatorState animatorState)		{			animatorState.SetBool(Active.Id, Active.Value);		}	}	[Serializable]	public struct SetHealthIconAnimatorState : ISetAnimatorState	{		public BoolId Active;		public void SetState(AnimatorState animatorState)		{			animatorState.SetBool(Active.Id, Active.Value);		}	}	[Serializable]	public struct SetKeyIconAnimatorState : ISetAnimatorState	{		public BoolId Active;		public void SetState(AnimatorState animatorState)		{			animatorState.SetBool(Active.Id, Active.Value);		}	}	[Serializable]	public struct SetCloseButtonAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetGameOverEllenAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetGameOverTextAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetLoadingCanvasAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetStartButtonAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetStartLogoAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetStartMenuCanvasAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetUIButtonAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetUICanvasAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetSpitterDeath_05AnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}	[Serializable]	public struct SetTestControllerAnimatorState : ISetAnimatorState	{		public void SetState(AnimatorState animatorState)		{		}	}}