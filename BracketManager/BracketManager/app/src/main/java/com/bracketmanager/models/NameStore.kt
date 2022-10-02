package com.bracketmanager.models

interface NameStore {
    fun findAll(): List<NameModel>
    fun create(name: NameModel)
    fun update(name: NameModel)
    fun delete(name: NameModel)
}