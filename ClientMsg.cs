using System;

public enum ClientMsg
{
	PeerConnectTimeOut,
	MasterPeerStartConnect,
	MasterPeerEndConnect,
	ModelChanged_Begin = 1000,
	ModelChanged_End = 5000,
	NotifyModel_master_begin,
	NotifyModel_master_end = 5300,
	NotifyModel_game_begin,
	NotifyModel_game_end = 5600,
	NotifyModel_friend_begin,
	NotifyModel_friend_end = 5700,
	NotifyModel_chat_begin,
	NotifyModel_chat_end = 5800,
	NotifyModel_teamroom_begin,
	NotifyModel_teamroom_end = 6000,
	NotifyModel_userdata_begin,
	NotifyModel_userdata_end = 6200,
	NotifyView_master_begin = 10000,
	NotifyView_master_end = 10300,
	NotifyView_game_begin,
	NotifyView_game_end = 10600,
	NotifyView_friend_begin,
	NotifyView_friend_end = 10700,
	NotifyView_chat_begin,
	NotifyView_chat_end = 10800,
	NotifyView_teamroom_begin,
	NotifyView_teamroom_end = 11000,
	NotifyView_gate_begin,
	NotifyView_gate_end = 12000,
	NotifyView_userdata_begin,
	NotifyView_userdata_end = 13000,
	NetBegin = 20000,
	NetEnd = 20100,
	V2C_begin = 21000,
	V2C_end = 23000,
	C2V_begin,
	C2V_end = 25000,
	C2C_begin,
	C2C_end = 26000,
	V2V_begin,
	V2V_end = 27000,
	GameLogic_Msg_Begin,
	GameLogic_Msg_End = 28000,
	BattleMsg_Begin,
	BattleMsg_End = 29000
}