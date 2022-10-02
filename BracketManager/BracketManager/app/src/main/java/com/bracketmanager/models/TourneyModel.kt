package com.bracketmanager.models

import android.os.Parcelable
import kotlinx.android.parcel.Parcelize

@Parcelize
data class TourneyModel(var tourneyid: String, var nameList: List<NameModel>,
                        var matchList: List<MatchModel>) : Parcelable