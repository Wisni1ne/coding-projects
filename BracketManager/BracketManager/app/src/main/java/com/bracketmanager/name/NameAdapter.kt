package com.bracketmanager.name

import android.view.LayoutInflater
import android.view.View
import android.view.ViewGroup
import androidx.recyclerview.widget.RecyclerView
import kotlinx.android.synthetic.main.card_name.view.*
import com.bracketmanager.R
import com.bracketmanager.models.NameModel

interface NameListener {
    fun onNameClick(name: NameModel)
}

class NameAdapter constructor(private var names: List<NameModel>,
                              private val listener: NameListener)
    : RecyclerView.Adapter<NameAdapter.MainHolder>() {

    override fun onCreateViewHolder(parent: ViewGroup, viewType: Int): MainHolder {
        return MainHolder(LayoutInflater.from(parent?.context).inflate(R.layout.card_name, parent, false))
    }

    override fun onBindViewHolder(holder: MainHolder, position: Int) {
        val name = names[holder.adapterPosition]
        holder.bind(name, listener)
    }

    override fun getItemCount(): Int = names.size

    class MainHolder constructor(itemView: View) : RecyclerView.ViewHolder(itemView) {

        fun bind(name: NameModel, listener: NameListener) {
            itemView.nameTitle.text = name.userid
            itemView.setOnClickListener { listener.onNameClick(name) }
        }
    }

}