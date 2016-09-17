[Profile: _VNM]
[3DNUS Profile Manager]
[Running On v2.5.3b of 3DNUS]

{
My.Settings.Load();
Me.Profile.VNM = My.Settings.Profile_Current_VNM
Me.Refresh();
Load(VNM_CORE);
Load(SYS_UPD);
Load(VNM_SYS);
Load(VNM_SDMC);
Load(VNM_EXTR);
Load(VNM_LIB_CIA);

}

[End Of: Profile _VNM]