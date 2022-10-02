package com.bracketmanager.models

import android.content.Context
import com.google.gson.Gson
import com.google.gson.GsonBuilder
import com.google.gson.reflect.TypeToken
import org.jetbrains.anko.AnkoLogger
import com.bracketmanager.helpers.*
import java.util.*

val JSON_FILE = "names.json"
val gsonBuilder = GsonBuilder().setPrettyPrinting().create()
val listType = object : TypeToken<java.util.ArrayList<NameModel>>() {}.type

class NameJSONStore : NameStore, AnkoLogger {

    val context: Context
    var names = mutableListOf<NameModel>()

    constructor (context: Context) {
        this.context = context
        if (exists(context, JSON_FILE)) {
            deserialize()
        }
    }

    override fun findAll(): MutableList<NameModel> {
        return names
    }

    override fun create(name: NameModel) {

        names.add(name)
        serialize()
    }

    override fun update(name: NameModel) {

    }

    override fun delete(name: NameModel) {
        names.remove(name)
        serialize()
    }

    private fun serialize() {
        val jsonString = gsonBuilder.toJson(names, listType)
        write(context, JSON_FILE, jsonString)
    }

    private fun deserialize() {
        val jsonString = read(context, JSON_FILE)
        names = Gson().fromJson(jsonString, listType)
    }

}