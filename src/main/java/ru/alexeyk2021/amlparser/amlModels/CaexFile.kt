package ru.alexeyk2021.amlparser.amlModels

import lombok.Data
import javax.xml.bind.annotation.*

//
//@Data
//@JacksonXmlRootElement(localName = "CAEXFile")
//data class CaexFile(
//   @JacksonXmlProperty(localName = "InstanceHierarchy")
//    val instanceHierarchy: MutableList<InstanceHierarchy>,
//    @JacksonXmlProperty(localName = "InterfaceClassLib")
//    val interfaceClassLib: MutableList<InterfaceClassLib>,
//    @JacksonXmlProperty(localName = "RoleClassLib")
//    val roleClassLib: MutableList<RoleClassLib>,
//    @JacksonXmlProperty(localName = "SystemUnitClassLib")
//    val systemUnitClassLib: MutableList<SystemUnitClassLib>
//)

@Data
@XmlAccessorType(XmlAccessType.FIELD)
data class SourceDocumentInformation(
    @XmlAttribute(name = "OriginName")
    val originName: String = "",
    @XmlAttribute(name = "OriginID")
    val originID: String = "",
    @XmlAttribute(name = "OriginVersion")
    val originVersion: String = "",
    @XmlAttribute(name = "LastWritingDateTime")
    val lastWritingDateTime: String = "",
    @XmlAttribute(name = "OriginProjectID")
    val originProjectID: String = "",
    @XmlAttribute(name = "OriginProjectTitle")
    val originProjectTitle: String = "",
    @XmlAttribute(name = "OriginRelease")
    val originRelease: String = "",
    @XmlAttribute(name = "OriginVendor")
    val originVendor: String = "",
    @XmlAttribute(name = "OriginVendorURL")
    val originVendorURL: String = ""
)

@Data
@XmlRootElement(name = "CAEXFile")
@XmlAccessorType(XmlAccessType.FIELD)
data class CaexFile(
    @XmlAttribute(name = "SchemaVersion")
    val schemeVersion: String = "",
    @XmlAttribute(name = "FileName")
    val filename: String = "",
    @field:XmlElement(name = "SuperiorStandardVersion")
    val superiorStandardVersion: String = "",
    @field:XmlElement(name = "SourceDocumentInformation")
    val sourceDocumentInformation: SourceDocumentInformation = SourceDocumentInformation(),
    @field:XmlElement(name = "InstanceHierarchy")
    val instanceHierarchyList: MutableList<InstanceHierarchy> = mutableListOf(),
    @field:XmlElement(name = "InterfaceClassLib")
    val interfaceClassLibList: MutableList<InterfaceClassLib> = mutableListOf(),
    @field:XmlElement(name = "RoleClassLib")
    val roleClassLibList: MutableList<RoleClassLib> = mutableListOf(),
    @field:XmlElement(name = "SystemUnitClassLib")
    val systemUnitClassLibList: MutableList<SystemUnitClassLib> = mutableListOf()
)

@Data
@XmlAccessorType(XmlAccessType.FIELD)
data class InstanceHierarchy(
    @XmlAttribute(name = "Name")
    val name: String = "",
    @field:XmlElement(name = "Version")
    val version: String = "",
    @field:XmlElement(name = "InternalElement")
    val internalElementList: MutableList<InternalElement> = mutableListOf()
)

@Data
@XmlAccessorType(XmlAccessType.FIELD)
data class InternalElement(
    @XmlAttribute(name = "Name")
    val name: String = "",
    @XmlAttribute(name = "ID")
    val id: String = "",
    @field:XmlElement(name = "InternalElement")
    val internalElementList: MutableList<InternalElement> = mutableListOf(),
    @field:XmlElement(name = "ExternalInterface")
    val externalInterfaceList: MutableList<ExternalInterface> = mutableListOf(),
    @field:XmlElement(name = "Attribute")
    val attributesList: MutableList<Attribute> = mutableListOf()
)

@Data
@XmlAccessorType(XmlAccessType.FIELD)
data class Attribute(
    @XmlAttribute(name = "Name")
    val name: String = "",
    @field:XmlElement(name = "Value")
    val value: String = ""
)

@Data
@XmlAccessorType(XmlAccessType.FIELD)
data class ExternalInterface(
    @XmlAttribute(name = "Name")
    val name: String = "",
    @XmlAttribute(name = "ID")
    val id: String = "",
    @XmlAttribute(name = "RefBaseClassPath")
    val refBaseClassPath: String = ""
)

@Data
@XmlAccessorType(XmlAccessType.FIELD)
data class InterfaceClassLib(
    @XmlAttribute(name = "Name")
    val name: String = "",
    @field:XmlElement(name = "Version")
    val version: String = "",
    @field:XmlElement(name = "InterfaceClass")
    val interfaceClassList: MutableList<InterfaceClass> = mutableListOf()
)

@Data
@XmlAccessorType(XmlAccessType.FIELD)
data class InterfaceClass(
    @XmlAttribute(name = "Name")
    val name: String = "",
    @field:XmlElement(name = "InterfaceClass")
    val interfaceClassList: MutableList<InterfaceClass> = mutableListOf()
)

@Data
@XmlAccessorType(XmlAccessType.FIELD)
data class RoleClassLib(
    @XmlAttribute(name = "Name")
    val name: String = "",
    @field:XmlElement(name = "Version")
    val version: String = "",
    @field:XmlElement(name = "RoleClass")
    val roleClassList: MutableList<RoleClass> = mutableListOf()
)

@Data
@XmlAccessorType(XmlAccessType.FIELD)
data class RoleClass(
    @XmlAttribute(name = "Name")
    val name: String = "",
    @field:XmlElement(name = "RoleClass")
    val roleClassList: MutableList<RoleClass> = mutableListOf()
)

@Data
@XmlAccessorType(XmlAccessType.FIELD)
data class SystemUnitClassLib(
    @XmlAttribute(name = "Name")
    val name: String = "",
    @field:XmlElement(name = "Version")
    val version: String = "",
    @field:XmlElement(name = "SystemUnitClass")
    val systemUnitClass: MutableList<SystemUnitClass> = mutableListOf()
)

@Data
@XmlAccessorType(XmlAccessType.FIELD)
data class SystemUnitClass(
    @XmlAttribute(name = "Name")
    val name: String = "",
    @XmlAttribute(name = "ID")
    val id: String = "",
    @field:XmlElement(name = "Attribute")
    val attributesList: MutableList<Attribute> = mutableListOf(),
    @field:XmlElement(name = "ExternalInterface")
    val externalInterfaceList: MutableList<ExternalInterface> = mutableListOf(),
    @field:XmlElement(name = "InternalElement")
    val internalElementList: MutableList<InternalElement> = mutableListOf(),
    @field:XmlElement(name = "SupportedRoleClass")
    val supportedRoleClass: SupportedRoleClass = SupportedRoleClass(),
)

data class SupportedRoleClass(
    @XmlAttribute(name = "RefRoleClassPath")
    val refRoleClassPath: String = ""
)


