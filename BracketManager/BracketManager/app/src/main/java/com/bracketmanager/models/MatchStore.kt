package com.bracketmanager.models

interface MatchStore {
    fun findAll(): List<MatchModel>
    fun create(match: MatchModel)
    fun update(match: MatchModel)
    fun delete(match: MatchModel)
}