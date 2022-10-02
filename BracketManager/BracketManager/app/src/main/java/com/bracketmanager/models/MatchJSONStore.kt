package com.bracketmanager.models

import android.content.Context
import com.google.gson.Gson
import com.google.gson.GsonBuilder
import com.google.gson.reflect.TypeToken
import org.jetbrains.anko.AnkoLogger
import com.bracketmanager.helpers.*
import java.util.*

val JSON_FILE_M = "matches.json"
val gsonBuilderM = GsonBuilder().setPrettyPrinting().create()
val listTypeM = object : TypeToken<java.util.ArrayList<MatchModel>>() {}.type

class MatchJSONStore : MatchStore, AnkoLogger {

    val context: Context
    var matches = mutableListOf<MatchModel>()

    constructor (context: Context) {
        this.context = context
        if (exists(context, JSON_FILE_M)) {
            deserialize()
        }
    }

    override fun findAll(): MutableList<MatchModel> {
        return matches
    }

    override fun create(match: MatchModel) {

        matches.add(match)
        serialize()
    }

    override fun update(match: MatchModel) {

        var foundMatch: MatchModel? = matches?.find { p -> p.nameOne == match.nameOne }
        if (foundMatch != null) {
            foundMatch.scoreOne = match.scoreOne
            foundMatch.scoreTwo = match.scoreTwo
            serialize()
        }
    }

    override fun delete(match: MatchModel) {
        matches.removeAll(matches)
        serialize()
    }

    private fun serialize() {
        val jsonString = gsonBuilderM.toJson(matches, listTypeM)
        write(context, JSON_FILE_M, jsonString)
    }

    private fun deserialize() {
        val jsonString = read(context, JSON_FILE_M)
        matches = Gson().fromJson(jsonString, listTypeM)
    }

}