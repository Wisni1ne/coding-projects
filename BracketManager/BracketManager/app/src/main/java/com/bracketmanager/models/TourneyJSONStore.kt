package com.bracketmanager.models

import android.content.Context
import com.google.gson.Gson
import com.google.gson.GsonBuilder
import com.google.gson.reflect.TypeToken
import org.jetbrains.anko.AnkoLogger
import com.bracketmanager.helpers.*
import java.util.*

val JSON_FILE_T = "tourneys.json"
val gsonBuilderT = GsonBuilder().setPrettyPrinting().create()
val listTypeT = object : TypeToken<java.util.ArrayList<TourneyModel>>() {}.type

class TourneyJSONStore : TourneyStore, AnkoLogger {

    val context: Context
    var tourneys = mutableListOf<TourneyModel>()

    constructor (context: Context) {
        this.context = context
        if (exists(context, JSON_FILE_T)) {
            deserialize()
        }
    }

    override fun findAll(): MutableList<TourneyModel> {
        return tourneys
    }

    override fun create(tourney: TourneyModel) {

        tourneys.add(tourney)
        serialize()
    }

    override fun update(tourney: TourneyModel) {

    }

    override fun delete(tourney: TourneyModel) {
        tourneys.remove(tourney)
        serialize()
    }

    private fun serialize() {
        val jsonString = gsonBuilderT.toJson(tourneys, listTypeT)
        write(context, JSON_FILE_T, jsonString)
    }

    private fun deserialize() {
        val jsonString = read(context, JSON_FILE_T)
        tourneys = Gson().fromJson(jsonString, listTypeT)
    }

}