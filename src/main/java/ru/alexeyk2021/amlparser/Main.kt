package ru.alexeyk2021.amlparser

import ru.alexeyk2021.amlparser.amlModels.CaexFile
import java.io.File
import javax.xml.bind.JAXBContext


fun main(args: Array<String>) {
    println("Hello world!")

    val xmlFile = File("src/main/java/ru/alexeyk2021/amlparser/TestAML.aml")
//    val xmlDoc: Document = DocumentBuilderFactory.newInstance().newDocumentBuilder().parse(xmlFile)

//    xmlDoc.documentElement.normalize()
//
//    println("Root Node:" + xmlDoc.documentElement.nodeName)
//
//    val InstanceHierarchy: NodeList = xmlDoc.getElementsByTagName("InstanceHierarchy")
//    for (i in 0..<InstanceHierarchy.length) {
//        val node = InstanceHierarchy.item(i) as Element
//        println(node.getAttribute("Name"))  //   <---MyHierarchy
//        if (node.nodeType != Node.TEXT_NODE) {
//            val subnodes = node.childNodes
//            for (j in 0..<subnodes.length){
//                val node = subnodes.item(j)
//            }
//        }
//    }
//    val xmlMapper = XmlMapper()
//    val myPOJO:RoleClassLib = xmlMapper.readValue(xmlFile.readText(), RoleClassLib::class.java)
//    println(myPOJO.toString())
    val jaxbContext: JAXBContext = JAXBContext.newInstance(CaexFile::class.java)
    val jaxbUnmarshaller = jaxbContext.createUnmarshaller()
    val caexFile: CaexFile = jaxbUnmarshaller.unmarshal(xmlFile) as CaexFile
    println(caexFile.toString())
}