package com.bracketmanager.models

import android.os.Parcelable
import kotlinx.android.parcel.Parcelize

@Parcelize
data class MatchModel(var nameOne: NameModel = NameModel(""), var nameTwo: NameModel = NameModel(""),
                      var scoreOne: String = "0", var scoreTwo: String = "0", var round: Int = 0) : Parcelable